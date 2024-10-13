using FluentValidation;
using tasks_apis.Dtos;

public class TaskDTOValidator : AbstractValidator<CreateTaskDTO>
{
    public TaskDTOValidator()
    {
        RuleFor(x => x.Text)
            .NotEmpty().WithMessage("Task text cannot be empty.")
            .NotEqual("string").WithMessage("Invalid value for Task text.");

        RuleFor(x => x.Level)
            .NotEmpty().WithMessage("Task level is required.");


        RuleFor(x => x.ExternalInternal)
            .NotEmpty().WithMessage("Task ei is required.");

        RuleFor(x => x.Timing)
            .NotEmpty().WithMessage("Task timing is required.")
            .NotEqual("string").WithMessage("Invalid value for Task timing.");
    }
}
