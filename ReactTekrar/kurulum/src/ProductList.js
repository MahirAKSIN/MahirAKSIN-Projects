import React from "react";

function ProductList(props) {
  const { product } = props;
  return (
    <div>
      <tr>
        <td>id</td>
        <td>Name</td>
        <td>Unit Price</td>
      </tr>
      {product.map((item, key) => {
        return (
          <tr>
            <td>{item.id}</td>
            <td>{item.name}</td>
            <td>{item.unitPrice}</td>
          </tr>
        );
      })}
    </div>
  );
}

export default ProductList;
