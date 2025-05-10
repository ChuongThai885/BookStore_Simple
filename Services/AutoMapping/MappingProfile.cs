using AutoMapper;

namespace BookStore.API.Services.AutoMapping
{
    public class MappingProfile: Profile
    { 
        public MappingProfile() {
            CreateMap<BookCreateDTO, Models.Book>()
                .ForMember(dest => dest.Author, opt => opt.Ignore())
                .ForMember(dest => dest.Genre, opt => opt.Ignore());
            CreateMap<Models.Author, BookAuthorDTO>();
            CreateMap<Models.Genre, BookGenreDTO>();
            CreateMap<Models.Book, BookDTO>();
        }
    }
}
