import {
	Container,
	FormControl,
	FormControlLabel,
	Radio,
	RadioGroup,
	TextField,
} from "@material-ui/core";

const DishesForm = () => {
	return (
		<Container>
			<FormControl >
				<TextField
					name="name"
					label="Name"
					variant="outlined"
					value={name}
					// onChange={onChange}
				/>
				<TextField
					name="description"
					label="Description"
					variant="outlined"
					multiline
					rows={4}
					// value={description}
					// onChange={onChange}
				/>
				<TextField
					name="price"
					label="Price"
					variant="outlined"
					type="number"
					// value={price}
					// onChange={onChange}
				/>
				<TextField
					name="servingSize"
					label="Serving Size"
					variant="outlined"
					// value={servingSize}
					// onChange={onChange}
				/>
				<RadioGroup
					name="type"
					// value={type}
					// onChange={onChange}
				>
					<FormControlLabel
						value={0}
						control={<Radio />}
						label="Product Type 1"
					/>
					<FormControlLabel
						value={1}
						control={<Radio />}
						label="Product Type 2"
					/>
				</RadioGroup>
			</FormControl>
		</Container>
	);
};

export default DishesForm;
