﻿using Smurfs.Entities.Conrete;
using Smurfs.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smurfs.Business.Abstract
{
    public interface ICallService
    {
        Task<List<Call>> GetAll();
        Task<List<CallParameters>> GetAllParameters();

        Task<Call> GetById(int id);
        Task<CallParameters> GetByIdParameters(int id);

        void Create(Call entity);
        void CreateParameters(CallParameters entity);

        void Update(Call entity);
        void UpdateParameters(CallParameters entity);

        void Delete(Call entity);
        void DeleteParameters(CallParameters entity);

        public CallParameters Calculate(int callId);
       
    }
}