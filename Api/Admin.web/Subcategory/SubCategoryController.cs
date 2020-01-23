using System;
using System.Threading.Tasks;
using Api.Contracts.Version1;
using Application.Admin.web.SubCategories.Commands;
using Application.Admin.web.SubCategories.Dtos;
using Application.Admin.web.SubCategories.Queries;
using Application.Envelopes;
using Application.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Admin.web.Subcategory {
    [ApiController]
    [Route (V1Routes.V1UriBase + "Subcategory")]
    [Produces ("Application/json")]
    public class SubCategoryController : ControllerBase {
        private readonly IMediator _mediator;
        private readonly IEnvelopes<ListSubcategoryResponseDto> _envelope;
        public SubCategoryController (IMediator mediator, IEnvelopes<ListSubcategoryResponseDto> envelope) {
            _envelope = envelope;
            _mediator = mediator;

        }
        /// <summary>
        /// get a list of all subcategories in specific category.
        /// </summary>
        /// <returns>all subcategories of specific category</returns>
        /// <response code="200">get a list of all subcategories of specific category</response>
        /// <response code="500">If internal server error</response> 
        [HttpPost]
        [Route ("[Action]/{catId}")]
        [ProducesResponseType (StatusCodes.Status200OK)]
        [ProducesResponseType (StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetSubcategories ([FromBody] PaginationAndFilteringPropscs props, Guid catId) {
            var subcategories = await _mediator.Send (new SubCatList.Query (props, catId, _envelope));
            return Ok (subcategories);
        }
        /// <summary>
        /// get details of a specific Subcategory.
        /// </summary>
        /// <param name="id">Guid Of Subcategory Id</param>  
        /// <returns>specific Subcategory</returns>
        /// <response code="200">get details of a specific Subcategory.</response>
        /// <response code="400">If the id is invalid</response>  
        /// <response code="500">If internal server error</response> 
        [HttpGet ("{id}")]
        [ProducesResponseType (StatusCodes.Status200OK)]
        [ProducesResponseType (StatusCodes.Status400BadRequest)]
        [ProducesResponseType (StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Details (Guid id) {
            var subcategories = await _mediator.Send (new SubCatDetails.Query { Id = id });
            return Ok (subcategories);
        }

        /// <summary>
        /// Creates a Subcategory.
        /// </summary>      
        /// <param name="command"></param>
        /// <returns>A newly created Subcategory</returns>
        /// <response code="201">Returns the newly created Subcategory</response>
        /// <response code="400">If the item is null</response>  
        /// <response code="500">If internal server error</response> 
        [HttpPost]
        [ProducesResponseType (StatusCodes.Status201Created)]
        [ProducesResponseType (StatusCodes.Status400BadRequest)]
        [ProducesResponseType (StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Create ([FromForm]CreateSubcategory.Command command) {
            var newSubcategory = await _mediator.Send (command);
            var uri = $"{Request.Scheme}://${Request.Host.ToUriComponent()}/V1Routes.V1UriBase/${newSubcategory.Id}";
            return Created (uri, newSubcategory);
        }
        /// <summary>
        /// Updates a specific Subcategory.
        /// </summary>
        /// <param name="id" >Type Guid</param>  
        /// <param name="command" ></param>  
        /// <returns>Updated Subcategory</returns>
        /// <response code="200">Returns Updated Subcategory</response>
        /// <response code="400">If the id or object is invalid</response>  
        /// <response code="500">If internal server error</response> 
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Edit(Guid id, [FromForm]EditSubCategory.Command command)
        {
           var subcategory = await _mediator.Send(command);
           return Ok(subcategory);
        }
        /// <summary>
        /// Deletes a specific Subcategory.
        /// </summary>
        /// <param name="id">Guid data type</param> 
        /// <response code="204">for success</response>
        /// <response code="400">If the id is invalid</response>  
        /// <response code="500">If internal server error</response>  
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Delete(Guid id)
        {
           var subcategory = await _mediator.Send(new DeleteSubcategory.Command { Id = id });
           return NoContent();
        }
    }
}