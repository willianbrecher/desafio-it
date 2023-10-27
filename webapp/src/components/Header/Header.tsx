import { AppBar, Toolbar, Typography } from "@material-ui/core"
import { Outlet } from "react-router"

export const Header = () => {
    return <>
        <AppBar>
            <Toolbar>
                <Typography variant="h6" component="div">
                    RIP - Restaurante Italiano Paranaese
                </Typography>
            </Toolbar>
        </AppBar>
    </>
}