using AutoMapper;
using ProdajaMobilnihAplikacija.Model.Requests;
using ProdajaMobilnihAplikacija.WebAPI.Database;
using Rent_A_Car.WebAPI.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProdajaMobilnihAplikacija.WebAPI.Services
{
    public class KlijentService : IKlijentService
    {
        private readonly Prodaja_Mobilnog_SoftveraContext _context;
        private readonly IMapper _mapper;

        public KlijentService(Prodaja_Mobilnog_SoftveraContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public Model.Klijent Authenticiraj(string username, string pass)
        {
            var user = _context.Klijents.FirstOrDefault(x => x.KorisnickoIme == username);

            if (user != null)
            {
                var newHash = GenerateHash(user.LozinkaSalt, pass);

                if (newHash == user.LozinkaHash)
                {
                    return _mapper.Map<Model.Klijent>(user);
                }
            }
            return null;
        }
        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }
        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }


        public List<Model.Klijent> Get(KlijentSearchRequest request)
        {
            //querry
            var query = _context.Klijents.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Ime))
            {
                query = query.Where(x => x.Ime.ToLower().StartsWith(request.Ime.ToLower()));
            }

            if (!string.IsNullOrWhiteSpace(request?.Prezime))
            {
                query = query.Where(x => x.Prezime.ToLower().StartsWith(request.Prezime.ToLower()));
            }

            var list = query.ToList();
            return _mapper.Map<List<Model.Klijent>>(list);
        }
        public Model.Klijent GetById(int id)
        {
            var entity = _context.Klijents.Find(id);
            return _mapper.Map<Model.Klijent>(entity);
        }
        public Model.Klijent Insert(KlijentInsertRequest request)
        {
            var entity = _mapper.Map<Database.Klijent>(request);

            if (request.Password != request.PasswordConfirmation)
            {
                throw new UserException("Passwordi se ne slažu!");
            }
            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);

            _context.Klijents.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Klijent>(entity);
        }
        public Model.Klijent Update(int id, KlijentInsertRequest request)
        {
            var entity = _context.Klijents.Find(id);
            _context.Klijents.Attach(entity);
            _context.Klijents.Update(entity);


            if (!string.IsNullOrWhiteSpace(request.Password))
            {
                if (request.Password != request.PasswordConfirmation)
                {
                    throw new Exception("Paswordi se ne slažu!!!");
                }
                entity.LozinkaSalt = GenerateSalt();
                entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);
            }

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Klijent>(entity);
        }

        public Model.Klijent Registracija(KlijentInsertRequest request)
        {
            var entity = _mapper.Map<Database.Klijent>(request);

            if (request.Password != request.PasswordConfirmation)
            {
                throw new UserException("Passwordi se ne slažu!");
            }
            var zaposlenkUsername = _context.Zaposleniks.FirstOrDefault(x => x.KorisnickoIme == request.KorisnickoIme);
            if (zaposlenkUsername != null)
            {
                throw new UserException("Username se već koristi!");
            }
            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);

            _context.Klijents.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Klijent>(entity);
        }
    }
}
