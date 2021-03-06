﻿using System;
using CloudFlare.Client.Models;

namespace CloudFlare.Client.Test.Credentials
{
    public static class Credentials
    {
        private static string ApiKey => Environment.GetEnvironmentVariable("ApiKey", EnvironmentVariableTarget.Process);

        private static string ApiToken => Environment.GetEnvironmentVariable("ApiToken", EnvironmentVariableTarget.Process);

        private static string EmailAddress => Environment.GetEnvironmentVariable("EmailAddress", EnvironmentVariableTarget.Process);

        public static Authentication Authentication => new Authentication(EmailAddress, ApiKey, ApiToken);
    }
}