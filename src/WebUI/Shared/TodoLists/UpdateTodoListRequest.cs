﻿using FluentValidation;

namespace RapidBlazor2.WebUI.Shared.TodoLists;

public class UpdateTodoListRequest
{
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;
}

public class UpdateTodoListRequestValidator
    : AbstractValidator<UpdateTodoListRequest>
{
    public UpdateTodoListRequestValidator()
    {
        RuleFor(v => v.Title)
            .MaximumLength(240)
            .NotEmpty();
    }
}
