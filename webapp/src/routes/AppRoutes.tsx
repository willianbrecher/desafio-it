import { BrowserRouter, Route, Routes } from "react-router-dom";
import DishesForm from "../pages/Dishes/Form/Dishes";

export function AppRoutes() {
	return (
		<BrowserRouter>
			<Routes>
				<Route path="/" element={<DishesForm />} />
			</Routes>
		</BrowserRouter>
	);
}
