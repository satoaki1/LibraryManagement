
﻿using LibraryManagement.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

﻿using System;
using LibraryManagement.Dtos;

using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace LibraryManagement.Interfaces
{

    public interface IBookAppService : ICrudAppService<BookDto, Guid, PagedAndSortedResultRequestDto, CreateBookDto, UpdateBookDto>
    {
    }
}


