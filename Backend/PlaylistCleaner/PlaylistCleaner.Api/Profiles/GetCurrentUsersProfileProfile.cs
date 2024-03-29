﻿using AutoMapper;
using PlaylistCleaner.Api.Responses;
using PlaylistCleaner.ApiClients.Responses.SpotifyApiClientResults.GetCurrentUsersProfile;

namespace PlaylistCleaner.Api.Profiles;

internal sealed class GetCurrentUsersProfileProfile : Profile
{
    public GetCurrentUsersProfileProfile()
    {
        CreateMap<ApiClients.Responses.SpotifyApiClientResults.GetCurrentUsersProfile.ImageObject, GetCurrentUsersProfileResponseImage>();

        CreateMap<ApiClients.Responses.SpotifyApiClientResults.GetCurrentUsersProfile.Followers, GetCurrentUsersProfileResponseFollower>();

        CreateMap<ApiClients.Responses.SpotifyApiClientResults.GetCurrentUsersProfile.External_Urls, string>()
            .ConstructUsing(s => s.spotify);

        CreateMap<Explicit_Content, GetCurrentUsersProfileResponseExplicitContent>();

        CreateMap<GetCurrentUsersProfileResult, GetCurrentUsersProfileResponse>()
        .ForCtorParam(nameof(GetCurrentUsersProfileResponse.explicit_content), opt => opt.MapFrom(s => s.explicit_content))
        .ForCtorParam(nameof(GetCurrentUsersProfileResponse.spotify_external_url), opt => opt.MapFrom(s => s.external_urls))
        .ForCtorParam(nameof(GetCurrentUsersProfileResponse.followers), opt => opt.MapFrom(s => s.followers))
        .ForCtorParam(nameof(GetCurrentUsersProfileResponse.images), opt => opt.MapFrom(s => s.images));
    }
}