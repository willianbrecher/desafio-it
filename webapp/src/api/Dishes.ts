import { IPageable, IPageableResult } from "../types/types";
import { handleErrors, post } from "./Common";

export const listDishes = async (obj: IPageable, url: string): Promise<IPageableResult> => {
    try {
        return (await post(`${url}/pageable-list`, obj)).data;
    } catch (e: any) {
        return handleErrors(e);
    }
};
