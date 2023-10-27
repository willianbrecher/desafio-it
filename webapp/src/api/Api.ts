import axios, { AxiosInstance } from "axios";

const api: AxiosInstance = axios.create({
	baseURL: "http://localhost:3030/",
	headers: {
		"Content-Type": "application/json;charset=utf-8",
	},
});

export default api;
