update Good set Condition = @Condition
    where good_id in (
        select copy_id from Rent
            where rent_id = @rent_id
    );