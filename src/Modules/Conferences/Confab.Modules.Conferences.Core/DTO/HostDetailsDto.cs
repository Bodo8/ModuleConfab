﻿using System.Collections.Generic;

namespace Confab.Modules.Conferences.Core.DTO;

internal class HostDetailsDto : HostDto
{
    public IReadOnlyList<ConferenceDto> Conferences { get; set; }
}