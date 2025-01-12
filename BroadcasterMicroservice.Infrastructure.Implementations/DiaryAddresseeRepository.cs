﻿using BroadcasterMicroservice.Domain.Entity;
using BroadcasterMicroservice.Domain.Entity.MongoModel;
using BroadcasterMicroservice.Domain.Repository.Abstractions;
using BroadcasterMicroservice.Infrastructure.Implementations.Base;
using BroadcasterMicroservice.Infrastructure.MongoDbContext.Abstraction;

namespace BroadcasterMicroservice.Infrastructure.Implementations
{
    public class DiaryAddresseeRepository(IMongoDBContext context) : BaseRepository<DiaryAddresseeMongo, DiaryAddressee,Guid>(context), IDiaryAddresseeRepository
    {
       
    }
}
