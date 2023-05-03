using SharedModule.Core.Primitives;

namespace FavoriteModule.Core.Entities
{
    public class Favorite : Entity
    {
        public string OwnerId { get; set; }
        public string ItemId { get; set; }

        public string TypeId { get; set; }

        public Type Type { get; set; }
    }
}
