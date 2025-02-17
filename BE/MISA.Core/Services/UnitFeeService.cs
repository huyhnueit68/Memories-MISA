﻿using AutoMapper;
using Microsoft.Extensions.Options;
using MISA.Core.Entities;
using MISA.Core.Interfaces.Repository;
using MISA.Core.Interfaces.Services;
using MISA.Core.Resources;
using MISA.Core.Resources.UnitFee;

namespace MISA.Core.Services
{
    public class UnitFeeService : BaseService<UnitFeeResource, CreateUnitFeeResource, UpdateUnitFeeResource, UnitFee>, IUnitFeeService
    {
        #region Constructor
        public UnitFeeService(IUnitFeeRepository UnitFeeRepository, IMapper mapper, IOptionsSnapshot<ResponseMessage> responseMessage) : base(UnitFeeRepository, mapper, responseMessage)
        {
        }
        #endregion
    }
}
