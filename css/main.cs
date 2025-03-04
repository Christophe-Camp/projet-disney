@charset "UTF-8";
@font-face {
  font-family: "avenir-book", "sans-serif";
  src: url("../../fonts/avenir/Avenir Book.ttf") format("ttf");
}
@font-face {
  font-family: "avenir-black", "sans-serif";
  src: url("../fonts/avenir/AvenirLTStd-Black.otf") format("ttf");
}
* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}

a {
  text-decoration: none;
}

li {
  list-style: none;
}

.primary-boutton a {
  font-family: "avenir-black", sans-serif;
  font-size: 48px;
}

.secondary-boutton {
  font-family: "avenir-book", sans-serif;
  text-transform: capitalize;
  font-weight: 100;
  font-size: 18px;
}

h1 {
  font-family: "avenir-black", sans-serif;
  font-size: 48px;
}

h2 {
  font-family: "avenir-black", sans-serif;
  font-size: 48px;
}

h3 {
  font-family: "avenir-black", sans-serif;
  font-size: 25px;
}

h3 span {
  font-family: "avenir-book", sans-serif;
}

span {
  font-size: 12px;
}

p {
  font-family: "avenir-book", sans-serif;
}

a {
  font-family: "avenir-book", sans-serif;
}

li {
  font-family: "avenir-book", sans-serif;
}

main, footer {
  background-color: #000000;
}

span {
  display: block;
}

.menu {
  position: absolute;
  top: 0.7rem;
  right: 4.3rem;
}

a {
  color: #c0c0c0;
}

@media (max-width: 768px) {
  .container {
    width: 100%;
  }
}
.container-fluide {
  background-image: url(../assets/images/bg/Background.png);
  background-repeat: no-repeat;
  background-size: cover;
  height: 42rem;
}
.container-fluide .banner-presentation {
  display: flex;
  align-items: center;
  justify-content: center;
  color: #c0c0c0;
}
.container-fluide .banner-presentation .title {
  text-align: center;
  color: #c0c0c0;
  margin-top: 10rem;
}

.logo-sup-banner {
  display: flex;
  justify-content: center;
  margin: 1rem 0;
}
.logo-sup-banner .logo {
  width: 40%;
}
.logo-sup-banner .logo .btn-banner {
  margin: 1rem 0;
}

.logo-left {
  text-align: center;
}
.logo-left img {
  padding: 0 1rem;
}

.logo-right img {
  padding: 0 0.4rem;
}

.description {
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
  gap: 2rem;
  margin: 2rem 0;
}

@media (max-width: 768px) {
  .container-fluide {
    background-repeat: no-repeat;
    width: 100%;
    height: 34.8rem;
  }
  .container-fluide .title {
    text-align: center;
    color: #c0c0c0;
    width: 30%;
    margin-top: 10rem;
  }
  .abonnement, .presentation {
    display: none;
  }
  li {
    display: none;
  }
}
.logo-left {
  display: none;
}

.nav-presentation ul {
  display: flex;
  gap: 2rem;
  align-items: center;
  justify-content: center;
  margin-top: 3.3rem;
  margin-bottom: 2.2rem;
}
.nav-presentation ul a {
  font-size: 20px;
}

.line {
  display: flex;
  justify-content: center;
  width: 100%;
  border: solid 2px #f9f9f9;
}

.abonnement {
  margin-top: 10rem;
}
.abonnement .encart {
  display: flex;
  flex-direction: column;
  align-items: center;
  gap: 1rem;
}

.abonnement h2, .abonnement p {
  color: white;
}

footer .container {
  padding: 2rem 0;
}
footer .container .img-footer {
  text-align: center;
  margin: 1rem;
}

.liens-footer {
  display: flex;
  align-items: center;
  justify-content: center;
}
.liens-footer ul {
  display: flex;
  gap: 2rem;
  margin-bottom: 1rem;
}
.liens-footer ul li {
  color: #c0c0c0;
}

.copyright {
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
  gap: 2rem;
}
.copyright p {
  color: #c0c0c0;
  margin-top: 1rem;
}

.cta {
  margin: 0;
}

.primary-boutton {
  display: flex;
  align-items: center;
  justify-content: center;
  background-color: #0063E5;
  width: 90%;
  height: 4.2rem;
  font-family: "avenir-book", sans-serif;
  font-size: 18px;
  border-radius: 0.3rem;
  text-transform: capitalize;
}

.card-abo .cta {
  display: flex;
  flex-direction: column;
  justify-content: flex-end;
  height: 20rem;
  gap: 1rem;
}
.card-abo .cta span {
  display: inline;
}
.card-abo .cta span .btn-abo {
  width: 95%;
  height: 3.8rem;
}

.card-abo ul {
  display: flex;
  flex-direction: column;
  gap: 2rem;
  margin-top: 1rem;
}
.card-abo ul li::before {
  content: "✔";
  margin-right: 1rem;
}

.menu {
  display: flex;
  align-items: center;
  justify-content: center;
  width: 6%;
  height: 3.1rem;
  border: 1px solid #c0c0c0;
  border-radius: 0.3rem;
  background-color: #000000;
}

.cards-presentation {
  display: flex;
  justify-content: center;
  flex-wrap: wrap;
  margin: 1rem;
  width: 90%;
  gap: 1rem;
}
.cards-presentation .card {
  width: 30%;
}
.cards-presentation .card img {
  width: 100%;
}

.cards-abonnement {
  display: flex;
  color: white;
  gap: 1rem;
  width: 85%;
  height: 32.6rem;
}
.cards-abonnement .card-abo {
  display: flex;
  flex-direction: column;
  border: 2px solid #c0c0c0;
  padding: 2rem;
}
.cards-abonnement .card-abo img {
  margin-right: 0.5rem;
  margin-bottom: 2rem;
}

.cards-abonnement h3, .cards-abonnement p {
  color: white;
}

.btn-abonnement {
  display: flex;
  align-items: center;
  border: 6px solid #2B2D37;
  border-radius: 5rem;
  width: 16%;
  background-color: #2B2D37;
  margin: 1rem;
}
.btn-abonnement .bundle {
  background-color: #0063E5;
  border-radius: 5rem;
  display: flex;
  align-items: center;
  justify-content: center;
  width: 100%;
  height: 3rem;
}

.disney {
  margin: 0 1rem;
}

/*# sourceMappingURL=main.cs.map */
