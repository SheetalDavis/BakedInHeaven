using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bake.DataService.Models;
using Bake.DataService.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AutoMapper;
using Bake.BusinessService.Dtos;

namespace Bake.Controllers
{
    //[Route("api/Customers")]
    [ApiController]
    class BakeController : ControllerBase
    {
        private readonly ICustomerRepo _repository;
        private readonly IMapper _mapper;
        private readonly IOrderRepo _order;
        private readonly IRegDishes _regDishes;
        private readonly ISpclDishRepo _spclDishes;
        public BakeController(ICustomerRepo repository, IMapper mapper, IOrderRepo order, IRegDishes regDishes, ISpclDishRepo spclDishes)
        {
            _repository = repository;
            _mapper = mapper;
            _order = order;
            _regDishes = regDishes;
            _spclDishes = spclDishes;
        }
        //private readonly CustomerRepo _repository = new CustomerRepo();
        // Get api/Customers
        [HttpGet]
        [Route("api/Customers")]
        public ActionResult<IEnumerable<CustomerReadDto>> GetAllUsers()
        {
            var customersDetails = _repository.GetAllUsers();
            return Ok(_mapper.Map<IEnumerable<CustomerReadDto>>(customersDetails));
        }
        // Get api/Customers/{id}
        [HttpGet("{id}", Name = "GetCustomerById")]
        public ActionResult<CustomerReadDto> GetCustomerById(int id)
        {
            var customerDetail = _repository.GetCustomersById(id);
            if (customerDetail != null)
            {
                return Ok(_mapper.Map<CustomerReadDto>(customerDetail));
            }
            return NotFound();

        }
        // POST api/Customer
        [HttpPost]
        public ActionResult<CustomerReadDto> CreateCustomer(CustomerCreateDto customerCreateDto)
        {
            var customerModel = _mapper.Map<Customers>(customerCreateDto);
            _repository.CreateCustomer(customerModel);
            _repository.SaveChanges();
            var customerReadDto = _mapper.Map<CustomerReadDto>(customerCreateDto);
            return Ok(_mapper.Map<CustomerReadDto>(customerModel));


        }
        // PUT api/command/{id}
        [HttpGet("{id}")]
        public ActionResult UpdateCustomer(int id, CustomerUpdateDto CustomerUpdateDto)
        {
            var customerfromupdate = _repository.GetCustomersById(id);
            if (customerfromupdate == null)
            {
                return NotFound();
            }
            _mapper.Map(CustomerUpdateDto, customerfromupdate);
            _repository.UpdateCustomer(customerfromupdate);
            _repository.SaveChanges();
            return NoContent();
        }

        // Order Table--------------------------------------------------------------------------------

        [Route("api/Orders")]
        //GET api/Orders
        [HttpGet]
        public ActionResult<IEnumerable<RDishesReadDto>> GetAllOrders()
        {
            var OrderDetails = _order.GetAllOrders();
            return Ok(_mapper.Map<IEnumerable<OrderReadDto>>(OrderDetails));
        }

        [HttpGet("{id}", Name = "GetOrdersById")]
        public ActionResult<OrderReadDto> GetOrdersById(int id)
        {
            var OrderDetail = _repository.GetCustomersById(id);
            if (OrderDetail != null)
            {
                return Ok(_mapper.Map<OrderReadDto>(OrderDetail));
            }
            return NotFound();

        }
        [HttpPost]
        public ActionResult<OrderReadDto> CreateOrder(OrderCreateDto OrderCreateDto)
        {
            var OrderModel = _mapper.Map<Orders>(OrderCreateDto);
            _order.CreateOrder(OrderModel);

            var customerReadDto = _mapper.Map<OrderReadDto>(OrderCreateDto);
            return Ok(_mapper.Map<OrderReadDto>(OrderModel));

        }
        //DELETE:Delete the order
        [HttpDelete("api/Bakery/order/{id}")]
        public ActionResult DeleteOrder(int id)
        {
            var OrderModelfromRepo = _order.GetOrdersById(id);
            if (OrderModelfromRepo == null)
            {
                return NotFound();
            }
            _order.DeleteOrder(OrderModelfromRepo);
            _order.SaveChanges();
            return NoContent();
        }

        //RDishes Table---------------------------------------------------------------------------
        [Route("api/rDishes")]
        //GET api/Orders
        [HttpGet]
        public ActionResult<IEnumerable<RDishesReadDto>> GetAllRDishes()
        {
            var RDishDetails = _regDishes.GetAllRDishes();
            return Ok(_mapper.Map<IEnumerable<RDishesReadDto>>(RDishDetails));
        }

        [HttpGet("{id}", Name = "GetRDishesById")]
        public ActionResult<RDishesReadDto> GetRDishesById(int id)
        {
            var RDishDetail = _regDishes.GetRDishesById(id);
            if (RDishDetail != null)
            {
                return Ok(_mapper.Map<RDishesReadDto>(RDishDetail));
            }
            return NotFound();

        }
        [HttpPost]
        public ActionResult<RDishesReadDto> CreateRDishes(RDishesCreateDto RDishesCreateDto)
        {
            var RdishModel = _mapper.Map<RDishes>(RDishesCreateDto);
            _regDishes.CreateRDishes(RdishModel);

            var RDishesReadDto = _mapper.Map<RDishesReadDto>(RDishesCreateDto);
            return Ok(_mapper.Map<RDishesReadDto>(RdishModel));

        }
        //DELETE:Delete the order
        [HttpDelete("api/Bake/RDishes/{id}")]
        public ActionResult DeleteRDishes(int id)
        {
            var RDishModelfromRepo = _regDishes.GetRDishesById(id);
            if (RDishModelfromRepo == null)
            {
                return NotFound();
            }
            _regDishes.DeleteRDishes(RDishModelfromRepo);
            _regDishes.SaveChanges();
            return NoContent();
        }
        //Special Dish Table----------------------------------------------------
        [Route("api/sDishes")]
        //GET api/Orders
        [HttpGet]
        public ActionResult<IEnumerable<SDishesReadDto>> GetAllSDishes()
        {
            var SDishDetails = _spclDishes.GetAllSDishes();
            return Ok(_mapper.Map<IEnumerable<SDishesReadDto>>(SDishDetails));
        }

        [HttpGet("{id}", Name = "GetRDishesById")]
        public ActionResult<SDishesReadDto> GetSDishesById(int id)
        {
            var SDishDetail = _spclDishes.GetSDishesById(id);
            if (SDishDetail != null)
            {
                return Ok(_mapper.Map<SDishesReadDto>(SDishDetail));
            }
            return NotFound();

        }
        [HttpPost]
        public ActionResult<SDishesReadDto> CreateSDishes(SDishesCreateDto SDishesCreateDto)
        {
            var SdishModel = _mapper.Map<SDishes>(SDishesCreateDto);
            _spclDishes.CreateSDishes(SdishModel);

            var RDishesReadDto = _mapper.Map<RDishesReadDto>(SDishesCreateDto);
            return Ok(_mapper.Map<RDishesReadDto>(SdishModel));

        }
        //DELETE:Delete the order
        [HttpDelete("api/Bake/RDishes/{id}")]
        public ActionResult DeleteSDishes(int id)
        {
            var SDishModelfromRepo = _spclDishes.GetSDishesById(id);
            if (SDishModelfromRepo == null)
            {
                return NotFound();
            }
            _spclDishes.DeleteSDishes(SDishModelfromRepo);
            _spclDishes.SaveChanges();
            return NoContent();
        }
    }
}
