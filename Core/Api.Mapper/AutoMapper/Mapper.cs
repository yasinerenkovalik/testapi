
using AutoMapper.Internal;
using AutoMapper;
using IMapper = AutoMapper.IMapper;

namespace Api.Mapper.AutoMapper;

public class Mapper: Api.Application2.Interfaces.AutoMapper.IMapper
{
    public static List<TypePair> TypePairs = new();

    private IMapper _mapper;
    public TDestination Map<TDestination, TSource>(TSource source, string? ignore = null)
    {
        Config<TDestination,TSource>(5,ignore);
        return _mapper.Map<TSource, TDestination>(source);
    }

    public IList<TDestination> Map<TDestination, TSource>(List<TSource> source, string? ignore = null)
    {
        Config<TDestination,TSource>(5,ignore);
        return _mapper.Map<IList<TSource>, IList<TDestination>>(source);
    }

    public TDestination Map<TDestination, TSource>(object source, string? ignore = null)
    {
        Config<TDestination,object>(5,ignore);
        return _mapper.Map<TDestination>(source);
    }

    public IList<TDestination> Map<TDestination, TSource>(List<object> source, string? ignore = null)
    {
        Config<TDestination,IList<object>>(5,ignore);
        return _mapper.Map<IList<TDestination>>(source);
    }

    protected void Config<TDestination, Tsource>(int depth=5, string? ignore = null)
    {
        var typePain = new TypePair(typeof(Tsource), typeof(TDestination));
        if(TypePairs.Any(a=>a.DestinationType==typePain.DestinationType && a.SourceType==typePain.SourceType )&& ignore is null)
            return;
        var config = new MapperConfiguration(cfg =>
        {
            foreach (var item in TypePairs)
            {
                if (ignore is not null)
                {
                    cfg.CreateMap(item.SourceType, item.DestinationType).MaxDepth(depth)
                        .ForMember(ignore, x => x.Ignore()).ReverseMap();
                }
                else
                {
                    cfg.CreateMap(item.SourceType, item.DestinationType).MaxDepth(depth).ReverseMap();
                }

            }
        });
        _mapper = config.CreateMapper();
    }
}