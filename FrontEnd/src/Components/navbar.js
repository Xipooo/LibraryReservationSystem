import react from 'react'
import { Home, Mine, Search } from './screens';
import { render } from 'react-dom';


class NavBar extends react.component{
    render(){
  const Index = ({ pathname }) => {
    switch(pathname) {
      case "./search":
        return <Search />;
      case "./mine":
        return <Mine />;
      default:
        return <Home />;
    }
  };
  
  let pathname = window.location.pathname;
  
  render(<Index pathname={pathname} />, document.getElementById("root"));
  
   window.addEventListener("popstate", () => {
    pathname = window.location.pathname;
  }
}