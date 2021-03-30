export const navigation = [
  {
    text: 'Home',
    path: '/home',
    icon: 'home'
  },
  {
    text: 'CRUD Facturación',
    icon: 'folder',
    items: [
      {
        text: 'Clientes',
        path: '/cliente'
      },
      {
        text: 'Productos',
        path: '/producto'
      },
      {
        text: 'Facturas',
        path: '/factura'
      },
      {
        text: 'Inventarios',
        path: '/inventario'
      }
    ]
  }
];
