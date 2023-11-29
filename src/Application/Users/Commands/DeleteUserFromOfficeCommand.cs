using Application.Common.Exceptions;
using Application.Common.Interfaces;
using Application.Common.Validators;
using Domain.Entities;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Users.Commands;

public class DeleteUserFromOfficeCommand : ICommand
{
    public required int UserId { get; set; }
    public required int OfficeId { get; set; }
    
    public class DeleteUserFromOfficeCommandHandler : IRequestHandler<DeleteUserFromOfficeCommand, Unit>
    {
        private readonly IApplicationDbContext _context;

        public DeleteUserFromOfficeCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteUserFromOfficeCommand request, CancellationToken cancellationToken)
        {
            var user = await _context.Users
                .Where(x => x.Id == request.UserId)
                .Include(x => x.UserOffices)
                .FirstOrDefaultAsync(cancellationToken);

            if (user is null)
            {
                throw new NotFoundException(nameof(ApplicationUser), request.UserId);
            }

            var relationship = new UserOffice() { UserId = request.UserId, OfficeId = request.OfficeId };
            if (!user.UserOffices.Contains(relationship))
            {
                return Unit.Value;
            }
            
            user.UserOffices.Remove(relationship);
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }

    public class DeleteUserFromOfficeCommandValidator : AbstractValidator<DeleteUserFromOfficeCommand>
    {
        public DeleteUserFromOfficeCommandValidator()
        {
            RuleFor(x => x.UserId).Id();
            RuleFor(x => x.OfficeId).Id();
        }
    }
}