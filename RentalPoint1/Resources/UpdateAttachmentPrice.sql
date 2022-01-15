update Attachment set
    Attachment.[TotalPrice(UAH)] = (
        select Attachment.Amount * Detail.[Price(UAH)]
            from Attachment 
            join [Set] on [Set].set_id = Attachment.set_id
            join Detail on Detail.detail_id = [Set].detail_id
        where Attachment.attachment_id = @attachment_id
        )
    where Attachment.attachment_id = @attachment_id;