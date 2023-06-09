﻿using Application.AuthorServices.Dtos;
using Application.Base;
using Application.BookRequestServices.Dtos;
using Domain.Data;
using Domain.Operation;
using Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BookRequestServices
{
    public class BookRequestService : IBookRequestService
    {
        private readonly IGenericRepository<BookRequest> _bookRequestRepository;

        public BookRequestService(IGenericRepository<BookRequest> bookRequestRepository)
        {
            _bookRequestRepository = bookRequestRepository;
        }

        public async Task<RequestResultDTO> GenerateBookRequest(CreateBookRequestDTO model)
        {
            try
            {
                BookRequest bookRequest = new BookRequest
                {
                    LectorId = model.LectorId,
                    DateRequestOpen = model.DateRequestOpen,
                    DateRequestClosed = model.DateRequestClosed,
                    RequestStatus = model.RequestStatus,
                    BookRequestDetails = model.BookRequestDetails
                    .Select(r=> new BookRequestDetail
                    {
                        BookId = r.BookId,
                    }).ToList(),
                };

                _bookRequestRepository.Create(bookRequest);
                await _bookRequestRepository.CommitAsync();

                return new RequestResultDTO
                {
                    SuccesMessage = "Request created successfully",
                    Success = true,
                    Error = false
                };
            }
            catch (Exception exc)
            {
                return new RequestResultDTO
                {
                    Success = false,
                    Error = true,
                    ErrorMessage = exc.InnerException?.Message
                };
            }
        }

        public async Task<RequestResultDTO> DisableBookRequest(int id)
        {
            try
            {
                await _bookRequestRepository.Disable(id);
                await _bookRequestRepository.CommitAsync();

                return new RequestResultDTO
                {
                    SuccesMessage = "Request disabled successfully",
                    Success = true,
                    Error = false
                };
            }
            catch (Exception exc)
            {

                return new RequestResultDTO
                {
                    Success = false,
                    Error = true,
                    ErrorMessage = exc.InnerException?.Message
                };
            }
        }

        public async Task<List<BookRequestDTO>> GetAllBookRequests()
        {
            return await _bookRequestRepository.GetAll<BookRequest>()
                .Select(x => new BookRequestDTO
                {
                    Id = x.Id,
                    Lector = x.Lector.Name,
                    LectorId = x.Id,
                    DateRequestClosed = x.DateRequestClosed,
                    DateRequestOpen = x.DateRequestOpen,
                    RequestStatus = x.RequestStatus,
                    BookRequestDetails = x.BookRequestDetails
                    .Select(r=> new BookRequestDetailDTO
                    {
                        Id =r.Id,
                        BookRequestId = x.Id,
                        BookId = r.BookId,
                        Book = r.Book.Title
                    }).ToList()
                }).ToListAsync();
        }

        public async Task<BookRequestDTO> GetBookRequestById(int id)
        {
            var bookRequest = await _bookRequestRepository.GetById(id);

            return new BookRequestDTO
            {
                Id = bookRequest.Id,
                Lector = bookRequest.Lector.Name,
                LectorId = bookRequest.Id,
                DateRequestClosed = bookRequest.DateRequestClosed,
                DateRequestOpen = bookRequest.DateRequestOpen,
                RequestStatus = bookRequest.RequestStatus,
                BookRequestDetails = bookRequest.BookRequestDetails
                    .Select(r => new BookRequestDetailDTO
                    {
                        Id = r.Id,
                        BookRequestId = bookRequest.Id,
                        BookId = r.BookId,
                        Book = r.Book.Title
                    }).ToList()
            };
        }

        public async Task<RequestResultDTO> UpdateBookRequest(BookRequestDTO model)
        {
            try
            {
                var bookRequest = await _bookRequestRepository.GetById(model.Id);
                bookRequest.LectorId = model.LectorId;
                bookRequest.DateRequestClosed = model.DateRequestClosed;
                bookRequest.DateRequestOpen = model.DateRequestOpen;
                bookRequest.RequestStatus = model.RequestStatus;



                _bookRequestRepository.Update(model.Id, bookRequest);

                await _bookRequestRepository.CommitAsync();

                return new RequestResultDTO
                {
                    SuccesMessage = "Book UPDATED successfully",
                    Success = true,
                    Error = false
                };
            }
            catch (Exception exc)
            {
                return new RequestResultDTO
                {
                    Success = false,
                    Error = true,
                    ErrorMessage = exc.InnerException?.Message
                };
            }
        }
    }
}
