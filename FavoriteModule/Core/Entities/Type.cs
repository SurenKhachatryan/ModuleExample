using SharedModule.Core.Primitives;
using System.Collections.Generic;

namespace FavoriteModule.Core.Entities
{
    public class Type : Entity
    {
        private List<Favorite> _favorites = new();

        public string Name { get; private set; }
        public IReadOnlyCollection<Favorite> Favorites { get; set; }

        private Type() { }

        public Type(string name)
        {
            Name = name;
        }

        public void AddFavorite(Favorite model)
        {
            _favorites.Add(model);
        }

        public void Update(string name)
        {
            Name = name;
        }

        public void DeleteFavorite(Favorite model)
        {
            _favorites.Remove(model);
        }
    }
}
