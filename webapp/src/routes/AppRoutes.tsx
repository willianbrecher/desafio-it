import { BrowserRouter, Route, Routes } from "react-router-dom";
import Menu from "../components/Menu/Menu";
import DishesForm from "../pages/Dishes/Form/Dishes";
import HomePage from "../pages/Admin/HomePage/HomePageAdmin";
import HomePageAdmin from "../pages/Admin/HomePage/HomePageAdmin";
import HomePageClient from "../pages/Client/HomePage/HomePageClient";

export function AppRoutes() {
	return (
		<BrowserRouter>
			<Routes>
				<Route element={<Menu />}>
					<Route path="/" element={<></>} />
					<Route path="form" element={<DishesForm />} />
					<Route path="admin" element={<HomePageAdmin />} />
					<Route path="client" element={<HomePageClient />} />
				</Route>
			</Routes>
		</BrowserRouter>
	);
}
