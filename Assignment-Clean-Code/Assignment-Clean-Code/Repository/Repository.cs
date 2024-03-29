﻿using Assignment_Clean_Code.Entities;

namespace Assignment_Clean_Code.Repository
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly DbContext<T> _context;

        public Repository(DbContext<T> context)
        {
            _context = context;
        }

        public int SaveSpeaker(T speaker)
        {
            if (speaker == null)
            {
                throw new ArgumentNullException("Invalid speaker");
            }

            int newId = new Random().Next(1, 10000000);
            speaker.Id = newId;
            _context.Entities.Add(speaker);

            return newId;
        }

        public T? GetEntityById(int id)
        {
            return _context.Entities.SingleOrDefault(e => e.Id == id);
        }
    }
}
