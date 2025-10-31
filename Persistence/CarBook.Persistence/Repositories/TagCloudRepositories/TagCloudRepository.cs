using CarBook.Application.Interfaces.TagCloudInterfaces;
using CarBook.Persistence.Context;
using CarBook.Domain.Entities;



namespace CarBook.Persistence.Repositories.TagCloudRepositories
{
    public class TagCloudRepository: ITagCloudRepository
    {
        private readonly CarBookContext _context;
        public TagCloudRepository(CarBookContext context)
        {
            _context = context;
        }

        public List<TagCloud> GetTagCloudsByBlogId(int id)
        {
            var values =  _context.TagClouds.Where(t => t.BlogID == id).ToList();
            return values;
        }
    }
}
