﻿namespace AngleSharp.DOM
{
    using AngleSharp.DOM.Collections;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The Element interface represents an object within a DOM document. 
    /// </summary>
    [DomName("Element")]
    public interface IElement : INode, IParentNode
    {        
        /// <summary>
        /// Gets the namespace prefix of this element.
        /// </summary>
        [DomName("prefix")]
        String Prefix { get; }

        /// <summary>
        /// Gets the local part of the qualified name of this element.
        /// </summary>
        [DomName("localName")]
        String LocalName { get; }

        /// <summary>
        /// Gets the namespace URI of this element.
        /// </summary>
        [DomName("namespaceURI")]
        String NamespaceUri { get; }

        /// <summary>
        /// Gets the sequence of associated attributes.
        /// </summary>
        [DomName("attributes")]
        AttrContainer Attributes { get; }

        /// <summary>
        /// Gets the list of class names.
        /// </summary>
        [DomName("classList")]
        ITokenList ClassList { get; }

        /// <summary>
        /// Gets or sets the value of the class attribute.
        /// </summary>
        [DomName("className")]
        String ClassName { get; set; }

        /// <summary>
        /// Gets or sets the id value of the element.
        /// </summary>
        [DomName("id")]
        String Id { get; set; }

        /// <summary>
        /// Returns a boolean value indicating whether the specified element has the specified attribute or not.
        /// </summary>
        /// <param name="name">The attributes name.</param>
        /// <returns>The return value of true or false.</returns>
        [DomName("hasAttribute")]
        Boolean HasAttribute(String name);

        /// <summary>
        /// Returns a boolean value indicating whether the specified element has the specified attribute or not.
        /// </summary>
        /// <param name="namespaceUri">A string specifying the namespace of the attribute.</param>
        /// <param name="localName">The attributes name.</param>
        /// <returns>The return value of true or false.</returns>
        [DomName("hasAttributeNS")]
        Boolean HasAttribute(String namespaceUri, String localName);

        /// <summary>
        /// Returns the value of the named attribute on the specified element.
        /// </summary>
        /// <param name="name">The name of the attribute whose value you want to get.</param>
        /// <returns>If the named attribute does not exist, the value returned will be null, otherwise the attribute's value.</returns>
        [DomName("getAttribute")]
        String GetAttribute(String name);

        /// <summary>
        /// Returns the value of the named attribute on the specified element.
        /// </summary>
        /// <param name="namespaceUri">A string specifying the namespace of the attribute.</param>
        /// <param name="localName">The name of the attribute whose value you want to get.</param>
        /// <returns>If the named attribute does not exist, the value returned will be null, otherwise the attribute's value.</returns>
        [DomName("getAttributeNS")]
        String GetAttribute(String namespaceUri, String localName);

        /// <summary>
        /// Adds a new attribute or changes the value of an existing attribute on the specified element.
        /// </summary>
        /// <param name="name">The name of the attribute as a string.</param>
        /// <param name="value">The desired new value of the attribute.</param>
        /// <returns>The current element.</returns>
        [DomName("setAttribute")]
        void SetAttribute(String name, String value);

        /// <summary>
        /// Adds a new attribute or changes the value of an existing attribute on the specified element.
        /// </summary>
        /// <param name="namespaceUri">A string specifying the namespace of the attribute.</param>
        /// <param name="name">The name of the attribute as a string.</param>
        /// <param name="value">The desired new value of the attribute.</param>
        [DomName("setAttributeNS")]
        void SetAttribute(String namespaceUri, String name, String value);

        /// <summary>
        /// Removes an attribute from the specified element.
        /// </summary>
        /// <param name="name">Is a string that names the attribute to be removed.</param>
        /// <returns>The current element.</returns>
        [DomName("removeAttribute")]
        void RemoveAttribute(String name);

        /// <summary>
        /// Removes an attribute from the specified element.
        /// </summary>
        /// <param name="namespaceUri">A string specifying the namespace of the attribute.</param>
        /// <param name="localName">Is a string that names the attribute to be removed.</param>
        /// <returns>The current element.</returns>
        [DomName("removeAttributeNS")]
        void RemoveAttribute(String namespaceUri, String localName);

        /// <summary>
        /// Returns a set of elements which have all the given class names.
        /// </summary>
        /// <param name="classNames">A string representing the list of class names to match; class names are separated by whitespace.</param>
        /// <returns>A collection of elements.</returns>
        [DomName("getElementsByClassName")]
        HTMLCollection GetElementsByClassName(String classNames);

        /// <summary>
        /// Returns a NodeList of elements with the given tag name. The complete document is searched, including the root node.
        /// </summary>
        /// <param name="tagName">A string representing the name of the elements. The special string "*" represents all elements.</param>
        /// <returns>A collection of elements in the order they appear in the tree.</returns>
        [DomName("getElementsByTagName")]
        HTMLCollection GetElementsByTagName(String tagName);

        /// <summary>
        /// Returns a list of elements with the given tag name belonging to the given namespace.
        /// The complete document is searched, including the root node.
        /// </summary>
        /// <param name="namespaceUri">The namespace URI of elements to look for.</param>
        /// <param name="tagName">Either the local name of elements to look for or the special value "*", which matches all elements.</param>
        /// <returns>A collection of elements in the order they appear in the tree.</returns>
        [DomName("getElementsByTagNameNS")]
        HTMLCollection GetElementsByTagNameNS(String namespaceUri, String tagName);

        ContentEditableMode ContentEditable { get; set; }

        IStringMap Dataset { get; }

        DirectionMode Dir { get; set; }

        String InnerHTML { get; set; }

        Boolean IsContentEditable { get; }

        String Lang { get; set; }

        Element NextElementSibling { get; }

        String OuterHTML { get; set; }

        Element PreviousElementSibling { get; }

        Boolean Spellcheck { get; set; }

        CSSStyleDeclaration Style { get; }

        Int32 TabIndex { get; set; }

        String TagName { get; }

        String Title { get; set; }
    }
}
