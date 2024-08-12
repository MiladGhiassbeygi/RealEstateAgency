namespace CleanArc.Application.Features.Order.Queries.GetAllOrders;

public record GetAllOrdersQueryResult(int OrderId,string OrderName,long OrderOwnerId,string OrderOwnerUserName);