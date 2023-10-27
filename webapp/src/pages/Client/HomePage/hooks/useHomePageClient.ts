import { useEffect, useState } from "react";
import { listDishes } from "../../../../api/Dishes";
import { IDishes, IPageableResult } from "../../../../types/types";

export const useHomePageClient = () => {

    const pageable = {
        filter: "",
        pageSize: 5000,
        currentPage: 1,
        orderBy: 1    
    }

    const [dishes, setDishes] = useState<IDishes[]>([]);
    useEffect(() => {
        listDishes(pageable, "api/dishes").then((result: IPageableResult) =>{
            setDishes(result.results);
        });
    }, []);

    return {dishes};
}
