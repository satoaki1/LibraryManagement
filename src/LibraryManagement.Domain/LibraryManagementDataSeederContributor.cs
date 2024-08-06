using LibraryManagement.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
﻿using System;
using System.Threading.Tasks;
using LibraryManagement.Models;
using LibraryManagement.Enums;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace LibraryManagement;

public class LibraryManagementDataSeederContributor : IDataSeedContributor, ITransientDependency
{
	private readonly IRepository<Book, Guid> _bookRepository;

	public LibraryManagementDataSeederContributor(IRepository<Book, Guid> bookRepository)
	{
		_bookRepository = bookRepository;
	}

	public async Task SeedAsync(DataSeedContext context)
	{
		if (await _bookRepository.GetCountAsync() <= 0)
		{
			await _bookRepository.InsertAsync(
				new Book
				{
					ISBN = "978-0-099-59008-8",
					Title = "Sapiens: A Brief History of Humankind",
					Author = "Yuval Noah Harari",
					Publisher = "Harper",
					PublicationDate = new DateTime(2015, 2, 10),
					PageCount = 0,
					Genre = BookGenre.NonFiction,
					Format = BookFormat.Hardcover,
					Status = BookStatus.Available,
					Language = "English",
					Description = "Published by Yuval Noah Harari in 2011 by Hebrew.",
					Price = 15.96M,
					CopiesAvailable = 5,
					Location = "Subang Jaya, Selangor",
					Tags = {},
					DateAdded = new DateTime(2020, 4, 6),
					LastBorrowedDate = new DateTime(2022, 12, 31)
				},
				autoSave: true
			);
        }
	}
}