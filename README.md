 <h1>Traffic Light Simulator</h1>
 <p>This project implements a customizable, event-driven Traffic Light User Control in C# Windows Forms. It automatically cycles through Red, Green, and Yellow states based on configurable timers and raises custom events to notify the parent form of state transitions.</p>

<h2>Visual Overview</h2>
<ul>
        <li><strong>User Control Design:</strong><br><img width="274" height="393" alt="image" src="https://github.com/user-attachments/assets/d28c4f3f-7826-4e7b-a2f9-6904101c2258" />
</li>
        <li><strong>Form Implementation:</strong> <img width="886" height="533" alt="image" src="https://github.com/user-attachments/assets/6bdda2fb-f343-4d40-8d10-963a9e88c4a1" />
</li>
</ul>

<h2>Key Features</h2>
    <ul>
        <li><strong>Automated Cycle:</strong> Transitions logically from Red &rarr; Yellow &rarr; Green &rarr; Yellow &rarr; Red using a built-in tick timer.</li>
        <li><strong>Configurable Durations:</strong> Independent properties to set the countdown durations for Red, Yellow, and Green lights.</li>
        <li><strong>Custom Event Handling:</strong> Fires specific events (<code>onRedLight</code>, <code>onYellowLight</code>, <code>onGreenLight</code>) upon state changes, passing the active color and timer data via <code>CustomEventArgs</code>.</li>
        <li><strong>Manual Override:</strong> Allows explicit color changes at runtime via the <code>LightChange()</code> method.</li>
    </ul>

  <h2>Properties &amp; Events</h2>
    <table>
        <thead>
            <tr>
                <th>Element</th>
                <th>Type</th>
                <th>Description</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td><strong>RedTimer</strong></td>
                <td>Property (<code>int</code>)</td>
                <td>Duration for the Red light state.</td>
            </tr>
            <tr>
                <td><strong>GreenTimer</strong></td>
                <td>Property (<code>int</code>)</td>
                <td>Duration for the Green light state.</td>
            </tr>
            <tr>
                <td><strong>YellowTimer</strong></td>
                <td>Property (<code>int</code>)</td>
                <td>Duration for the Yellow light state.</td>
            </tr>
            <tr>
                <td><strong>CurrentColor</strong></td>
                <td>Property (<code>enColors</code>)</td>
                <td>Gets or sets the current active light color (RED, YELLOW, GREEN).</td>
            </tr>
            <tr>
                <td><strong>onRedLight</strong></td>
                <td>Event</td>
                <td>Triggered when the light transitions to Red.</td>
            </tr>
            <tr>
                <td><strong>onYellowLight</strong></td>
                <td>Event</td>
                <td>Triggered when the light transitions to Yellow.</td>
            </tr>
            <tr>
                <td><strong>onGreenLight</strong></td>
                <td>Event</td>
                <td>Triggered when the light transitions to Green.</td>
            </tr>
        </tbody>
    </table>

  <h2>Usage Guide</h2>

  <p><strong>1. Starting the Sequence</strong><br>
    Once the <code>ctrlTraficLight</code> user control is added to your form, invoke the <code>ctrlStart()</code> method to begin the automated countdown cycle.</p>

<pre><code class="language-csharp">private void Form1_Load(object sender, EventArgs e)
{
    ctrlTraficLight1.ctrlStart();
}</code></pre>

  <p><strong>2. Subscribing to State Changes</strong><br>
    Bind event handlers to react whenever the traffic light changes color. The control passes custom event arguments containing the newly activated color.</p>

<pre><code class="language-csharp">private void ctrlTraficLight1_onGreenLight(object sender, ctrlTraficLight.CustomEventArgs e)
{
    // React to the green light
    MessageBox.Show(e.Color.ToString());
}

private void ctrlTraficLight1_onRedLight(object sender, ctrlTraficLight.CustomEventArgs e)
{
    // React to the red light
    MessageBox.Show(e.Color.ToString());
}</code></pre>
