export interface IPageable {
    filter: string,
    pageSize: number,
    currentPage: number,
    orderBy: number;
}

export interface IPageableResult {
    pageSize: number,
    currentPage: number,
    results: IDishes[]
}

export interface IDishes {
    id: string,
    name: string,
    description: string,
    price: number,
    servingSize: string,
    photo: string,
    type: number
}