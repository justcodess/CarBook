using CarBook.Application.Features.Mediator.Commands.CommentCommands;
using CarBook.Application.Features.Mediator.Commands.ReservationCommands;
using CarBook.Application.Features.RepositoryPattern;
using CarBook.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
            private readonly IGenericRepository<Comment> _commentRepository;
            private readonly IMediator _mediator;

            public CommentsController(
                IMediator mediator,
                IGenericRepository<Comment> commentRepository)
            {
                _mediator = mediator;
                _commentRepository = commentRepository;
            }
        

        [HttpGet]
        public IActionResult CommentList()
        {
            var comments = _commentRepository.GetAll();
            return Ok(comments);
        }
        [HttpPost]
        public IActionResult CreateComment(Comment comment)
        {
            _commentRepository.Create(comment);
            return Ok("Comment Info Added.");
        }
        [HttpPut]
        public IActionResult UpdateComment(Comment comment)
        {
            _commentRepository.Update(comment);
            return Ok("Comment Info Updated.");
        }
        [HttpDelete]
        public IActionResult RemoveComment(int id)
        {
            var value=_commentRepository.GetById(id);
            _commentRepository.Remove(value);
            return Ok("Comment Info Deleted.");
        }

        [HttpGet("{id}")]
        public IActionResult GetComment(int id) 
        {
            var comment = _commentRepository.GetById(id);
            return Ok(comment);
        }
        [HttpGet("CommentListByBlog")]
        public IActionResult CommentListByBlog(int id)
        {
            var comment = _commentRepository.GetCommentsByBlogId(id);
            return Ok(comment);
        }

        [HttpGet("CommentCountByBlog")]
        public IActionResult CommentCountByBlog(int id)
        {
            var values = _commentRepository.GetCountCommentByBlog(id);
            return Ok(values);
        }

        [HttpPost("CreateCommentWithMediator")]
        public async Task<IActionResult> CreateCommentWithMediator(CreateCommentCommand command)
        {
            await _mediator.Send(command);
            return Ok("Comment Info Added.");
        }
    }
}
