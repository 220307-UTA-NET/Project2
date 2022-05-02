export interface Product {
    id: number;
    name: string;
    description: string;
    price: number;
}

export const products = [
    {
        id: 1,
        name: 'Leaf Rake',
        price: 19.95,
        description: 'Leaf rake with 48-inch wooden handle'
    },
    {
        id: 2,
        name: 'Garden Cart',
        price: 32.99,
        description: '15 gallon capacity rolling garden cart'
    },
    {
        id: 3,
        name: 'Saw',
        price: 15.99,
        description: '15-inch steel blade hand saw'
    },
];