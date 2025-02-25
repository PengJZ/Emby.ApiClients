//
// RemoteSearchQueryGameInfo.swift
//
// Generated by swagger-codegen
// https://github.com/swagger-api/swagger-codegen
//

import Foundation



public struct RemoteSearchQueryGameInfo: Codable {

    public var searchInfo: GameInfo?
    public var itemId: Int64?
    public var searchProviderName: String?
    public var providers: [String]?
    public var includeDisabledProviders: Bool?

    public init(searchInfo: GameInfo? = nil, itemId: Int64? = nil, searchProviderName: String? = nil, providers: [String]? = nil, includeDisabledProviders: Bool? = nil) {
        self.searchInfo = searchInfo
        self.itemId = itemId
        self.searchProviderName = searchProviderName
        self.providers = providers
        self.includeDisabledProviders = includeDisabledProviders
    }

    public enum CodingKeys: String, CodingKey { 
        case searchInfo = "SearchInfo"
        case itemId = "ItemId"
        case searchProviderName = "SearchProviderName"
        case providers = "Providers"
        case includeDisabledProviders = "IncludeDisabledProviders"
    }

}
