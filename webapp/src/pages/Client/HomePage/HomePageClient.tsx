import { Button, Card, CardContent, CardHeader, CardMedia, Container, Typography } from "@material-ui/core";
import { Box } from "@material-ui/system";
import { useHomePageClient } from "./hooks/useHomePageClient";

const HomePageClient = () => {

    const { dishes } = useHomePageClient();
    console.log(dishes)
    const products = [
        {
            name: "string",
            description: "string",
            price: 0,
            servingSize: "string",
            type: 0
        },
        {
            name: "string 2",
            description: "string",
            price: 0,
            servingSize: "string",
            type: 0
        },
    ]

    return <>
        <Container sx={{ display: 'flex', justifyContent: 'center', alignItems: 'center' }}>
            <Box sx={{ display: 'flex', alignItems: 'center', flexWrap: 'wrap', gap: '20px' }}>
                {products.map((product, index) => (
                    <Card sx={{ maxWidth: 405 }}>
                        <CardHeader
                            title={product.name}
                        />
                        <CardMedia
                            component="img"
                            height="194"
                            image="/static/images/cards/paella.jpg"
                            alt="Paella dish"
                        />
                        <CardContent>
                            <Typography variant="body1" color="text.primary">
                                {product.price}
                            </Typography>
                            <Typography variant="body2" color="text.secondary">
                                {product.description}
                            </Typography>
                            <Button variant="text" >+</Button>
                        </CardContent>
                    </Card>
                ))}
            </Box>
        </Container>
    </>;
}

export default HomePageClient;