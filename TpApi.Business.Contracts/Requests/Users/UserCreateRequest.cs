﻿using TpApi.Business.Contracts.Common;

namespace TpApi.Business.Contracts.Requests.Users;

public record UserCreateRequest(
    string FirstName,
    string LastName,
    string Email
    ) : IRequest;