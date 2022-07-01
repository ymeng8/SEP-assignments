using System;

namespace Generics
{
    public class GenericRepository : IRepository<Entity>
    {
        public GenericRepository()
        {
        }

        List<Entity> entities = new List<Entity>();

        public void Add(Entity item)
        {
            entities.Add(item);
        }

        public IEnumerable<Entity> GetAll()
        {
            return entities;
        }

        public Entity GetById(int id)
        {
            foreach (Entity item in entities)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        public void Remove(Entity item)
        {
            entities.Remove(item);
        }

        public void Save()
        {
            Console.WriteLine("Saved successfully");
        }
    }
}

