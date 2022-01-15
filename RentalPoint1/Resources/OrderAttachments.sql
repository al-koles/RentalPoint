select Attachment.attachment_id
    from Attachment 
        join Rent on Rent.rent_id = Attachment.rent_id
        join [Order] on [Order].order_id = Rent.order_id
    where [Order].order_id = @order_id;