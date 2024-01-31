using AutoMapper;
using YoutubeBlog.Data.UnitOfWorks;
using YoutubeBlog.Entity.DTOs.Articles;
using YoutubeBlog.Entity.Entities;
using YoutubeBlog.Service.Services.Abstractions;

namespace YoutubeBlog.Service.Services.Concrete
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public ArticleService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task CreateArticleAsync(ArticleAddDto articleAddDto)
        {
            var userId = Guid.Parse("E5102E42-2326-40D7-AE9D-F6593CE92A48");
            var imageId = Guid.Parse("AED4065C-FFAB-4B86-8837-3858281A850F");
            var article = new Article(articleAddDto.Title, articleAddDto.Content, userId, articleAddDto.CategoryId, imageId);

            await unitOfWork.GetRepostitory<Article>().AddAsync(article);
            await unitOfWork.SaveAsync();
        }

        public async Task<List<ArticleDto>> GetAllArticlesWithCategoryNonDeletedAsync()
        {
            var articles = await unitOfWork.GetRepostitory<Article>().GetAllAsync(x=>!x.IsDeleted,x=>x.Category);
            var map = mapper.Map<List<ArticleDto>>(articles);

            return map;
                
        }

        public async Task<ArticleDto> GetArticleWithCategoryNonDeletedAsync(Guid articleId)
        {
            var article = await unitOfWork.GetRepostitory<Article>().GetAsync(x => !x.IsDeleted  && x.Id == articleId , x => x.Category);
            var map = mapper.Map<ArticleDto>(article);

            return map;

        }
        public async Task<string> UpdateArticleAsync(ArticleUpdateDto articleUpdateDto)
        {
            var article = await unitOfWork.GetRepostitory<Article>().GetAsync(x => !x.IsDeleted && x.Id == articleUpdateDto.Id, x => x.Category);

            article.Title = articleUpdateDto.Title;
            article.Content = articleUpdateDto.Content;
            article.CategoryId = articleUpdateDto.CategoryId;

            await unitOfWork.GetRepostitory<Article>().UpdateAsync(article);
            await unitOfWork.SaveAsync();

            return article.Title;
        }
        public async Task<string> SafeDeleteArticleAsync(Guid articleId)
        {
            var article = await unitOfWork.GetRepostitory<Article>().GetByGuidAsync(articleId);

            article.IsDeleted = true;
            article.DeletedDate = DateTime.Now;

            await unitOfWork.GetRepostitory<Article>().UpdateAsync(article);
            await unitOfWork.SaveAsync();

            return article.Title;
        }
    }
}
