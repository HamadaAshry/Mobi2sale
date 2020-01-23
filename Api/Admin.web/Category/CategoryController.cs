using System;
using System.Threading.Tasks;
using Api.Contracts.Version1;
using Application.Admin.web.Categories;
using Application.Admin.web.Categories.Commands;
using Application.Admin.web.Categories.Dtos;
using Application.Admin.web.Categories.Queries;
using Application.Envelopes;
using Application.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Admin.web.Category {
    [ApiController]
    [Route (V1Routes.V1UriBase + "Category")]
    [Produces ("Application/json")]
    public class CategoryController : ControllerBase {
        private readonly IMediator _mediator;
        public CategoryController (IMediator mediator) {
            _mediator = mediator;

        }
        /// <summary>
        /// get a list of all categories.
        /// </summary>
        /// <returns>all categories</returns>
        /// <response code="200">get a list of all categories..</response>
        /// <response code="500">If internal server error</response> 
        [HttpGet]
        [ProducesResponseType (StatusCodes.Status200OK)]
        [ProducesResponseType (StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get () {
            var categories = await _mediator.Send (new List.Query ());
            return Ok (categories);
        }
        /// <summary>
        /// get details of a specific Category.
        /// </summary>
        /// <param name="id">Guid Of category</param>  
        /// <returns>specific category</returns>
        /// <response code="200">get details of a specific Category.</response>
        /// <response code="400">If the id is invalid</response>  
        /// <response code="500">If internal server error</response> 
        [HttpGet ("{id}")]
        [ProducesResponseType (StatusCodes.Status200OK)]
        [ProducesResponseType (StatusCodes.Status400BadRequest)]
        [ProducesResponseType (StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Details (Guid id) {
            var categories = await _mediator.Send (new Details.Query { Id = id });
            return Ok (categories);
        }

        /// <summary>
        /// Creates a category.
        /// </summary>      
        /// <param name="command"></param>
        /// <returns>A newly created category</returns>
        /// <response code="201">Returns the newly created item</response>
        /// <response code="400">If the item is null</response>  
        /// <response code="500">If internal server error</response> 
        [HttpPost]
        [ProducesResponseType (StatusCodes.Status201Created)]
        [ProducesResponseType (StatusCodes.Status400BadRequest)]
        [ProducesResponseType (StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Create ([FromForm] Create.Command command) {
            var newCategory = await _mediator.Send (command);
            var uri = $"{Request.Scheme}://${Request.Host.ToUriComponent()}/V1Routes.V1UriBase/${newCategory.Id}";
            return Created (uri, newCategory);
        }
        /// <summary>
        /// Updates a specific Category.
        /// </summary>
        /// <param name="id" ></param>  
        /// <param name="command" ></param>  
        /// <returns>Updated category</returns>
        /// <response code="200">Returns Updated category</response>
        /// <response code="400">If the id or object is invalid</response>  
        /// <response code="500">If internal server error</response> 
        [HttpPut ("{id}")]
        [ProducesResponseType (StatusCodes.Status200OK)]
        [ProducesResponseType (StatusCodes.Status400BadRequest)]
        [ProducesResponseType (StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Edit (Guid id,[FromForm] Edit.Command command) {
            var Category = await _mediator.Send (command);
            return Ok (Category);
        }
        /// <summary>
        /// Deletes a specific Category.
        /// </summary>
        /// <param name="id"></param> 
        /// <response code="204">for success</response>
        /// <response code="400">If the id is invalid</response>  
        /// <response code="500">If internal server error</response>  
        [HttpDelete ("{id}")]
        [ProducesResponseType (StatusCodes.Status204NoContent)]
        [ProducesResponseType (StatusCodes.Status400BadRequest)]
        [ProducesResponseType (StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Delete (Guid id) {
            var Category = await _mediator.Send (new Delete.Command { Id = id });
            return NoContent ();
        }
    }
}