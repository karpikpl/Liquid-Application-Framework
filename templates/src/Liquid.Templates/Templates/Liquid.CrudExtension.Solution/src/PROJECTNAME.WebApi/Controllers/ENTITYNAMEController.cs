﻿using PROJECTNAME.Domain.Entities;
using MediatR;
using Liquid.WebApi.Http.Extensions.Crud.Controllers;

namespace PROJECTNAME.WebApi.Controllers
{
    public class ENTITYNAMEController : GenericCrudController<ENTITYNAMEEntity, ENTITYIDTYPE>
    {
        public ENTITYNAMEController(IMediator mediator) : base(mediator) { }
    }
}
