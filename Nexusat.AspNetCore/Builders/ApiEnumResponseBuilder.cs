﻿using System;
using System.Collections.Generic;
using System.Text;
using Nexusat.AspNetCore.Implementations;
using Nexusat.AspNetCore.Models;

namespace Nexusat.AspNetCore.Builders
{
    internal class ApiEnumResponseBuilder<T> : ApiResponseBuilderBase, IApiEnumResponseBuilder<T>
    {

        private IApiEnumResponse<T> Response => _response as IApiEnumResponse<T>;

        public ApiEnumResponseBuilder(): this(new ApiEnumResponse<T>()) { }
        public ApiEnumResponseBuilder(IApiEnumResponse<T> obj): base(obj) 
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
        }

        public IApiEnumResponse<T> GetResponse()
        {
            SingleInstanceChecker.CheckBuildStateForFinalBuild();
            return Response;
        }

        public IApiEnumResponseBuilder<T> SetData(IEnumerable<T> data)
        {
            SingleInstanceChecker.CheckBuildStateWhileBuilding();
            Response.Data = data;
            return this;
        }

        public IApiEnumResponseBuilder<T> SetHttpCode(int code)
        {
            InternalSetHttpCode(code);
            return this;
        }

        public IApiEnumResponseBuilder<T> SetException(Exception exception)
        {
            InternalSetException(exception);
            return this;
        }

        public IApiEnumResponseBuilder<T> SetStatusCodeFailed()
        {
            InternalSetStatusCodeFailed();
            return this;
        }

        public IApiEnumResponseBuilder<T> SetStatusCodeSuccess()
        {
            InternalSetStatusCodeSuccess();
            return this;
        }

        public IApiEnumResponseBuilder<T> SetStatusCode(string code)
        {
            InternalSetStatusCode(code);
            return this;
        }

        public IApiEnumResponseBuilder<T> SetDescription(string description)
        {
            InternalSetDescription(description);
            return this;
        }

        public IApiEnumResponseBuilder<T> SetUserDescription(string userDescription)
        {
            InternalSetUserDescription(userDescription);
            return this;
        }
    }
}
