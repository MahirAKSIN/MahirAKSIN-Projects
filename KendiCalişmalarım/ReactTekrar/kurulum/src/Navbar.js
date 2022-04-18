import React from "react";

function Navbar() {
  return (
    <>
      <div className="w3-col m6 w3-padding-large w3-hide-small">
        <img
          src="https://www.w3schools.com/w3images/hamburger.jpg"
          className="w3-round w3-image w3-opacity-min"
          alt="Table Setting"
          width={700}
          height={550}
        />
      </div>
      <div className="w3-col m6 w3-padding-large">
        <h1 className="w3-center">About Catering</h1>
        <br />
        <h5 className="w3-center">Tradition since 1889</h5>
        <p className="w3-large">
          The Catering was founded in blabla by Mr. Smith in lorem ipsum dolor
          sit amet, consectetur adipiscing elit consectetur adipiscing elit, sed
          do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim
          ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut
          aliquip ex ea commodo consequat. Duis aute iruredolor in reprehenderit
          in voluptate velit esse cillum dolore eu fugiat nulla pariatur.We only
          use <span className="w3-tag w3-light-grey">seasonal</span>{" "}
          ingredients.
        </p>
        <p className="w3-large w3-text-grey w3-hide-medium">
          Excepteur sint occaecat cupidatat non proident, sunt in culpa qui
          officia deserunt mollit anim id est laborum consectetur adipiscing
          elit, sed do eiusmod temporincididunt ut labore et dolore magna
          aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco
          laboris nisi ut aliquip ex ea commodo consequat.
        </p>
      </div>
    </>
  );
}
// <div className="w3-top">
//   <div
//     className="w3-bar w3-white w3-padding w3-card"
//     style={{ letterSpacing: 4 }}
//   >
//     <a href="#home" className="w3-bar-item w3-button">
//       Mahir Aksin
//     </a>
//     <div className="w3-right w3-hide-small">
//       <a href="#about" className="w3-bar-item w3-button">
//         About
//       </a>
//       <a href="#menu" className="w3-bar-item w3-button">
//         Menu
//       </a>
//       <a href="#contact" className="w3-bar-item w3-button">
//         Contact
//       </a>
//     </div>
//   </div>
// </div>
//   );
// }

export default Navbar;
