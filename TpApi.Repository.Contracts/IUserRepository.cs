﻿using TpApi.Entities;
using TpApi.Repository.Contracts.Common;

namespace TpApi.Repository.Contracts;

public interface IUserRepository : IReadRepository<User>, IWriteRepository<User>
{
    public Task<bool> IsEmailDuplicate(string email);
}