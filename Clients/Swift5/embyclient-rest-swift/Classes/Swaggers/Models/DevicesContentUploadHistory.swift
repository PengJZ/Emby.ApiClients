//
// DevicesContentUploadHistory.swift
//
// Generated by swagger-codegen
// https://github.com/swagger-api/swagger-codegen
//

import Foundation



public struct DevicesContentUploadHistory: Codable {

    public var deviceId: String?
    public var filesUploaded: [DevicesLocalFileInfo]?

    public init(deviceId: String? = nil, filesUploaded: [DevicesLocalFileInfo]? = nil) {
        self.deviceId = deviceId
        self.filesUploaded = filesUploaded
    }

    public enum CodingKeys: String, CodingKey { 
        case deviceId = "DeviceId"
        case filesUploaded = "FilesUploaded"
    }

}
