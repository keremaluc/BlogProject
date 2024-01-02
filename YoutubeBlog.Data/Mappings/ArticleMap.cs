using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Data.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(new Article
            {
                Id = Guid.NewGuid(),
                Title = "Asp.Net Core Deneme Makalesi 1",
                Content = "Asp.Net Core Lorem ipsum dolor sit amet consectetur adipiscing, elit ridiculus parturient nam consequat. Faucibus eros nisi in varius mollis vehicula tempor pellentesque, felis augue id ligula porta ante odio conubia suscipit, velit volutpat at taciti tellus dignissim semper. Eros quam mus sapien eget fringilla augue ullamcorper elementum sociosqu egestas non lectus, aenean mi hac magna suscipit est porta integer iaculis nascetur euismod. Faucibus interdum posuere condimentum tristique tempus in dictumst dis, dapibus eget semper dui commodo quis velit, ante mi fermentum fusce sapien luctus viverra. Nisl penatibus magna montes scelerisque duis arcu hendrerit dictumst rutrum fermentum, sollicitudin accumsan senectus aliquet non facilisis diam nullam eu nec, dignissim libero quis taciti nulla vestibulum platea semper justo. Lobortis libero nascetur augue facilisis tortor odio urna a volutpat porta, eleifend ullamcorper semper sociosqu cras dictum primis velit luctus ultricies ut, per turpis nostra litora habitant penatibus lacus conubia potenti. Netus eu placerat fermentum condimentum arcu pellentesque dictum blandit euismod vitae, dignissim felis eros inceptos ligula metus tempus justo nec himenaeos, molestie etiam posuere interdum nascetur gravida eleifend malesuada cursus. Dis pretium tincidunt maecenas magnis curabitur fames dui quis risus mus, sociosqu facilisis ante consequat odio faucibus penatibus diam pellentesque, luctus vel porttitor aliquet ridiculus himenaeos aenean gravida fringilla. Auctor orci fames maecenas taciti eros senectus magna semper quis ultricies, aliquam neque nascetur dui condimentum gravida montes elementum eu interdum tempor, enim pharetra nisl iaculis per quam vestibulum dictumst turpis. Varius libero nec class dis donec ad tristique ut faucibus, ultrices habitasse placerat quis platea sodales enim nullam dignissim convallis, urna dapibus taciti tellus integer praesent hac nunc. Montes pulvinar ante venenatis pharetra est porta, condimentum etiam vulputate tortor convallis tincidunt, turpis interdum mauris nostra pretium. Neque vel phasellus habitasse tortor nulla montes cursus tempor, pretium ad ac primis facilisis sollicitudin class tellus lobortis, netus accumsan ultricies potenti mollis fermentum integer.",
                ViewCount = 15,
                CategoryId = Guid.Parse("A2235FB5-9AA0-4103-BB4B-5BC2BB74457F"),
                ImageId = Guid.Parse("AED4065C-FFAB-4B86-8837-3858281A850F"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId = Guid.Parse("E5102E42-2326-40D7-AE9D-F6593CE92A48")
            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Visual Studio Core Deneme Makalesi 1",
                Content = "Visual Studio Lorem ipsum dolor sit amet consectetur adipiscing, elit ridiculus parturient nam consequat. Faucibus eros nisi in varius mollis vehicula tempor pellentesque, felis augue id ligula porta ante odio conubia suscipit, velit volutpat at taciti tellus dignissim semper. Eros quam mus sapien eget fringilla augue ullamcorper elementum sociosqu egestas non lectus, aenean mi hac magna suscipit est porta integer iaculis nascetur euismod. Faucibus interdum posuere condimentum tristique tempus in dictumst dis, dapibus eget semper dui commodo quis velit, ante mi fermentum fusce sapien luctus viverra. Nisl penatibus magna montes scelerisque duis arcu hendrerit dictumst rutrum fermentum, sollicitudin accumsan senectus aliquet non facilisis diam nullam eu nec, dignissim libero quis taciti nulla vestibulum platea semper justo. Lobortis libero nascetur augue facilisis tortor odio urna a volutpat porta, eleifend ullamcorper semper sociosqu cras dictum primis velit luctus ultricies ut, per turpis nostra litora habitant penatibus lacus conubia potenti. Netus eu placerat fermentum condimentum arcu pellentesque dictum blandit euismod vitae, dignissim felis eros inceptos ligula metus tempus justo nec himenaeos, molestie etiam posuere interdum nascetur gravida eleifend malesuada cursus. Dis pretium tincidunt maecenas magnis curabitur fames dui quis risus mus, sociosqu facilisis ante consequat odio faucibus penatibus diam pellentesque, luctus vel porttitor aliquet ridiculus himenaeos aenean gravida fringilla. Auctor orci fames maecenas taciti eros senectus magna semper quis ultricies, aliquam neque nascetur dui condimentum gravida montes elementum eu interdum tempor, enim pharetra nisl iaculis per quam vestibulum dictumst turpis. Varius libero nec class dis donec ad tristique ut faucibus, ultrices habitasse placerat quis platea sodales enim nullam dignissim convallis, urna dapibus taciti tellus integer praesent hac nunc. Montes pulvinar ante venenatis pharetra est porta, condimentum etiam vulputate tortor convallis tincidunt, turpis interdum mauris nostra pretium. Neque vel phasellus habitasse tortor nulla montes cursus tempor, pretium ad ac primis facilisis sollicitudin class tellus lobortis, netus accumsan ultricies potenti mollis fermentum integer.",
                ViewCount = 15,
                CategoryId = Guid.Parse("6B32F844-74A3-424B-9431-ECF65BEE09E4"),
                ImageId = Guid.Parse("60DA40E5-6AF5-4B7A-9435-A8E4F66BBE31"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId = Guid.Parse("45D910AF-E957-4880-88A7-49B1FCED6D24")
            }
            );
        }
    }
}
