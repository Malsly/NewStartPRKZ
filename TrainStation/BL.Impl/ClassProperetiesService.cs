﻿using BL.Abstract;
using BL.Abstract.ResultWrappers;
using BL.Impl.ResultWrappers;
using DAl.Impl.EFCore;
using DAl.Impl.Mappers;
using DAl.Impl.Repositories;
using DAl.Impl.UnitOfWork;
using Entities;
using ReposirotyAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL.Impl
{
    public class ClassProperetiesService : IClassProperetiesService
    {

        readonly ClassProperetiesMapper Mapper;
        readonly GenericRepository<ClassPropereties> Repo;

        public ClassProperetiesService()
        {
            Repo = new UnitOfWork().ClassPropereties;
            Mapper = new ClassProperetiesMapper(Repo);
        }

        public IDataResult<List<ClassProperetiesDTO>> GetAll()
        {
            return new DataResult<List<ClassProperetiesDTO>>()
            {
                Data = Repo.Get().Select(e => Mapper.Map(e)).ToList(),
                Message = ResponseMessageType.None,
                ResponseStatusType = ResponseStatusType.Successed
            };
        }

        public IDataResult<ClassProperetiesDTO> Get(int id)
        {
            return new DataResult<ClassProperetiesDTO>()
            {
                Data = Mapper.Map(Repo.GetByID(id)),
                Message = ResponseMessageType.None,
                ResponseStatusType = ResponseStatusType.Successed
            };
        }

        public IResult Add(ClassProperetiesDTO dto)
        {
            Repo.Insert(Mapper.DeMap(dto));
            return new Result()
            {
                Message = ResponseMessageType.None,
                ResponseStatusType = ResponseStatusType.Successed
            };
        }

        public IResult Update(ClassProperetiesDTO dto)
        {
            Repo.Update(Mapper.DeMap(dto));
            return new Result()
            {
                Message = ResponseMessageType.None,
                ResponseStatusType = ResponseStatusType.Successed
            };
        }

        public IResult Delete(int id)
        {
            Repo.Delete(id);
            return new Result()
            {
                Message = ResponseMessageType.None,
                ResponseStatusType = ResponseStatusType.Successed
            };
        }
    }
}
