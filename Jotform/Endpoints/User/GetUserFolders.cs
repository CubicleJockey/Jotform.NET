﻿using Jotform.Models.User;

namespace Jotform;

public partial class PostFormReports
{
    public async Task<JotformResult<GetUserFoldersResponse>?> GetUserFoldersAsync(CancellationToken cancellationToken = default)
        => await httpClient.GetFromJsonAsync<JotformResult<GetUserFoldersResponse>>("user/folders", jsonSerializerOptions, cancellationToken: cancellationToken);
}