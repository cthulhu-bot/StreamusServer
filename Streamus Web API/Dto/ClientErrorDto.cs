﻿using AutoMapper;
using Streamus_Web_API.Domain;

namespace Streamus_Web_API.Dto
{
    public class ClientErrorDto
    {
        public string Message { get; set; }
        public int LineNumber { get; set; }
        public string Url { get; set; }
        public string ClientVersion { get; set; }
        public string OperatingSystem { get; set; }
        public string Architecture { get; set; }

        public ClientErrorDto()
        {
            Message = string.Empty;
            Architecture = string.Empty;
            OperatingSystem = string.Empty;
            LineNumber = -1;
            Url = string.Empty;
            ClientVersion = string.Empty;
        }

        public static ClientErrorDto Create(ClientError clientError)
        {
            ClientErrorDto clientErrorDto = Mapper.Map<ClientError, ClientErrorDto>(clientError);
            return clientErrorDto;
        }
    }
}