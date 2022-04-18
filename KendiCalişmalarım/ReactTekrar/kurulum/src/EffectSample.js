import React, { useEffect, useState } from "react";

function EffectSample() {
  const [product, setProduct] = useState([]);
  const [supplier, setSupplier] = useState([]);

  useEffect(() => {
    fetch("https://northwind.vercel.app/api/suppliers").then((res) =>
      res.json().then((data) => setSupplier(data))
    );
  }, []);

  /* {useEffect(() => {
        fetch("https://northwind.vercel.app/api/products")
          .then((res) => res.json())

          .then((data) => {
            setProduct(data);
          });
      })} */
  return (
    <div>
      {/* <tr>
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
      })} */}

      <tr>
        <td>id</td>
        <td>Company Name</td>
        <td>Contact Name</td>
      </tr>
      {supplier.map((item, key) => {
        return (
          <tr>
            <td>{item.id}</td>
            <td>{item.companyName}</td>
            <td>{item.contactName}</td>
          </tr>
        );
      })}
    </div>
  );
}

export default EffectSample;
