/**
 * PlaylistCleaner.Api
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */
import { GetUserProfileResponseFollower } from './get-user-profile-response-follower';
import { GetUserProfileResponseImage } from './get-user-profile-response-image';


export interface GetUserProfileResponse { 
    displayName?: string | null;
    externalUrls?: Array<string> | null;
    followers?: GetUserProfileResponseFollower;
    href?: string | null;
    id?: string | null;
    images?: Array<GetUserProfileResponseImage> | null;
    type?: string | null;
    uri?: string | null;
}

