using FluentValidation;
using Tasks.Common.ViewModels;

public class CreateTaskValidator : AbstractValidator<CreateTaskDto>
{
    public CreateTaskValidator()
    {
        RuleFor(x => x.Text)
            .NotEmpty()
            .WithMessage("Task text cannot be empty.")
            .MaximumLength(256)
            .WithMessage("Max task length is 256 characters");

        RuleFor(x => x.Level)
            .NotEmpty().WithMessage("Task level is required.");


        RuleFor(x => x.ExternalInternal)
            .NotEmpty().WithMessage("Task ei is required.");

        //RuleFor(x => x.Timing)
        //    .NotEmpty().WithMessage("Task timing is required.")
        //    .NotEqual("string").WithMessage("Invalid value for Task timing.");
    }
}
