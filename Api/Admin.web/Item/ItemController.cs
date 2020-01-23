using System;
using System.Threading.Tasks;
using Api.Contracts.Version1;
using Application.Admin.web.Items.Command;
using Application.Admin.web.Items.Dtos;
using Application.Admin.web.Items.Quries;
using Application.Envelopes;
using Application.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Admin.web.Item {
    [ApiController]
    [Route (V1Routes.V1UriBase + "Item")]
    [Produces ("Application/json")]
    public class ItemController : ControllerBase {
        private readonly IMediator _mediator;
        private readonly IEnvelopes<ItemsResponseDto> _envelope;
        public ItemController (IMediator mediator, IEnvelopes<ItemsResponseDto> envelope) {
            _envelope = envelope;
            _mediator = mediator;

        }
        /// <summary>
        /// get  all items in specific subcategory.
        /// </summary>
        /// <param name="subcatId">Guid Of subcategory Id</param>  
       /// <param name="props">Guid Of subcategory Id</param>      
        /// <returns> all items in specific subcategory.</returns>
        /// <response code="200">get  all items in specific subcategory.</response>
        /// <response code="500">If internal server error</response> 
        [HttpPost]
        [Route ("[Action]/{subcatId}")]
        [ProducesResponseType (StatusCodes.Status200OK)]
        [ProducesResponseType (StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetItems (PaginationAndFilteringPropscs props, Guid subcatId) {
            var items = await _mediator.Send (new ItemList.Query (subcatId, props,_envelope));
            return Ok (items);
        }
        /// <summary>
        /// get details of a specific item.
        /// </summary>
        /// <param name="id">Guid Of item Id</param>  
        /// <returns>specific item</returns>
        /// <response code="200">get details of a specific item.</response>
        /// <response code="400">If the id is invalid</response>  
        /// <response code="500">If internal server error</response> 
        [HttpGet ("{id}")]
        [ProducesResponseType (StatusCodes.Status200OK)]
        [ProducesResponseType (StatusCodes.Status400BadRequest)]
        [ProducesResponseType (StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Details (Guid id) {
            var item = await _mediator.Send (new ItemDetails.Query { Id = id });
            return Ok (item);
        }

        /// <summary>
        /// Creates an item.
        /// </summary>      
        /// <param name="command"></param>
        /// <returns>A newly created item</returns>
        /// <response code="201">Returns the newly created item</response>
        /// <response code="400">If the item is null</response>  
        /// <response code="500">If internal server error</response> 
        [HttpPost]
        [ProducesResponseType (StatusCodes.Status201Created)]
        [ProducesResponseType (StatusCodes.Status400BadRequest)]
        [ProducesResponseType (StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Create ([FromForm]CreateItem.Command command) {
            var newItem = await _mediator.Send (command);
            var uri = $"{Request.Scheme}://${Request.Host.ToUriComponent()}/V1Routes.V1UriBase/item/${newItem.Id}";
            return Created (uri, newItem);
        }
        /// <summary>
        /// Updates a specific item.
        /// </summary>
        /// <param name="id" >Type Guid</param>  
        /// <param name="command" ></param>  
        /// <returns>edit item</returns>
        /// <response code="200">Returns edited item</response>
        /// <response code="400">If the id or object is invalid</response>  
        /// <response code="500">If internal server error</response> 
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Edit(Guid id, [FromForm]EditItem.Command command)
        {
           var item = await _mediator.Send(command);
           return Ok(item);
        }
        /// <summary>
        /// Deletes a specific item.
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
           var subcategory = await _mediator.Send(new DeleteItem.Command { Id = id });
           return NoContent();
        }
    }
}