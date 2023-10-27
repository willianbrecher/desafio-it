import { AppBar, Badge, Box, Container, Divider, Drawer, Grid, IconButton, List, ListItemButton, ListItemIcon, ListItemText, Paper, Toolbar, Typography } from "@material-ui/core";
import { Outlet, useNavigate } from "react-router";

const Menu = () => {

    const navigate = useNavigate();

    return <>
        <Box sx={{ display: 'flex' }}>
            <Drawer variant="permanent">
                <Toolbar
                    sx={{
                        display: 'flex',
                        alignItems: 'center',
                        justifyContent: 'flex-end',
                        px: [1],
                    }}
                >
                    <IconButton>
                    </IconButton>
                </Toolbar>
                <Divider />
                <List component="nav">
                    <ListItemButton onClick={() => navigate("client")}>
                        <ListItemIcon>
                        </ListItemIcon>
                        <ListItemText primary="Cliente" />
                    </ListItemButton>
                    <ListItemButton onClick={() => navigate("admin")}>
                        <ListItemIcon>
                        </ListItemIcon>
                        <ListItemText primary="Admin" />
                    </ListItemButton>
                </List>
            </Drawer>
            
            <Outlet />
        </Box>
    </>;
}

export default Menu;